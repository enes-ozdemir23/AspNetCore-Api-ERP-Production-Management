using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erp.BusinessLayer.Abstract;

namespace Erp.BusinessLayer.Concrete
{
    public class CodeGeneratorManager : ICodeGeneratorService
    {
        public string GenerateCustomerCode(string lastCode, string fixedPart)
        {
            if (string.IsNullOrEmpty(lastCode))
                return fixedPart + ".001";

            var parts = lastCode.Split('.');
            var lastNumberPart = parts.Last();
            int number = int.Parse(lastNumberPart);
            number++;
            var newNumber = number.ToString().PadLeft(3, '0');
            return fixedPart + "." + newNumber;
        }

        public string GenerateGroupCode(string lastCode)
        {
            if (string.IsNullOrEmpty(lastCode))
                return "01";

            int number = int.Parse(lastCode);
            number++;

            // minimum 2 hane, ama büyüyebilir
            return number.ToString().PadLeft(2, '0');
        }

        public string GenerateSequential(string lastCode, string prefix, int totalLength)
        {
            // 1️ Eğer hiç kayıt yoksa (ilk kayıt)
            if (string.IsNullOrEmpty(lastCode))
            {
                // prefix + 1 → başına sıfır doldur
                return prefix + "1".PadLeft(totalLength - prefix.Length, '0');
            }

            // 2️ Prefix'i kaldır (S000001504 → 000001504)
            var numberPart = lastCode.Substring(prefix.Length);

            // 3️ String → int çevir
            int number = int.Parse(numberPart);

            // 4️ 1 artır
            number++;

            // 5️ Tekrar string'e çevir ve sıfır doldur
            var newNumberPart = number.ToString()
                                      .PadLeft(totalLength - prefix.Length, '0');

            // 6️ Prefix ile birleştir
            return prefix + newNumberPart;
        }

        public string GenerateStockCode(string lastCode, string groupCode)
        {
            groupCode = groupCode.PadLeft(2, '0');

            string prefix = $"152.{groupCode}";

            if (string.IsNullOrEmpty(lastCode))
                return prefix + ".001";

            var parts = lastCode.Split('.');
            var lastNumber = parts.Last();

            int number = int.Parse(lastNumber);
            number++;

            return prefix + "." + number.ToString().PadLeft(3, '0');
        }
    }
    }

