class Solution {
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) {
        unordered_map<string, vector<string>> result;

        for (const auto& item : strs) {
            int count[26] = {};
            for (char c : item)
                count[c - 'a']++;

            string key;
            for (int i = 0; i < 26; i++) {
                key += to_string(count[i]);
                key += ',';
            }

            result[key].push_back(item);
        }

        vector<vector<string>> output;
        output.reserve(result.size());
        for (auto& [k, v] : result)
            output.push_back(move(v));

        return output;
    }
};