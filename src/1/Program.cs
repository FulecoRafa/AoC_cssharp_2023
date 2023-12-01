static char? getFirstNum(string src) {
    for(var i = 0; i < src.Length; i++) {
        char ch = src[i];
        if (ch >= '0' && ch <= '9') {
            return ch;
        }
    }
    return null;
}

static char? getLastNum(string src) {
    for(var i = src.Length - 1; i >= 0 ; i--) {
        char ch = src[i];
        if (ch >= '0' && ch <= '9') {
            return ch;
        }
    }
    return null;
}

using(var file = new StreamReader("./input.txt")) {
    string line;
    var result = 0;

    while((line = file.ReadLine()!) != null) {
        var firstNum = getFirstNum(line) ?? throw new InvalidDataException();
        var lastNum = getLastNum(line) ?? throw new InvalidDataException();
        var strNum = new string([firstNum, lastNum]);
        var num = Int32.Parse(strNum);
        result += num;
    }

    Console.WriteLine($"Result: {result}");
}
