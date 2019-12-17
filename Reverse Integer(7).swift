class Solution {
    func reverse(_ x: Int) -> Int {
        var x = x
        var output: Int = 0
        
        while x != 0 {
            let pop = x%10
            x = x/10
            output = output*10 + pop
            if (output > Int32.max || output < Int32.min) { return 0 }
        }
        
      return output
    }
}
