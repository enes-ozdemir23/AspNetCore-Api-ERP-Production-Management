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
    }
    }

