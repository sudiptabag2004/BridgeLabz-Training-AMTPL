public class Solution {
    public bool IsAnagram(string s, string t) {

        Dictionary<char,int> db = new Dictionary<char,int>();

        foreach(char c in s){
            if(!db.ContainsKey(c)){
                db[c] = 0;
            }
            db[c]++;
        }

        foreach(char c in t){
            if(!db.ContainsKey(c)){
                return false;
            }
            db[c]--;
        }

        foreach(var it in db){
            if(it.Value!=0){
                return false;
            }
        }

        return true;
        
    }
}