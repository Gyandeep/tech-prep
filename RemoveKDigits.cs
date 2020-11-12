using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RemoveKDigitsProgram {
    public string RemoveKdigits(string num, int k) {
        if (string.IsNullOrEmpty(num) || k == 0)
            return num;
        
        List<char> digits = new List<char>();
        foreach(var letter in num) {
            while (digits.Count > 0 && k > 0 && digits.Last() > letter) {
                k -= 1;
                digits.RemoveAt(digits.Count - 1);
            }
            
            // Console.WriteLine(letter);
            digits.Add(letter);
        }
        
        for (int i = 0; i < k; i++) {
            digits.RemoveAt(digits.Count - 1);
        }
        
        StringBuilder sb = new StringBuilder();
        bool leadingZero = true;
        foreach(var item in digits) {
            if (leadingZero && item == '0') {
                continue;
            }
            leadingZero = false;  
            sb.Append(item);
        }
        
        return sb.Length > 0 ? sb.ToString() : "0";
    }
}