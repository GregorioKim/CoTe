
// string숫자 → integer 변경 되면 true 리턴, 아니면 false
// ex) -123(string) → integer

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution {
    public bool solution(string s) {
        bool answer = true;

            int iStr = 0;
            if (Int32.TryParse(s, out iStr))
                answer = true;
            else
                answer = false;        

        return answer;
    }
}