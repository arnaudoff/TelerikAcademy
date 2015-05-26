// Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.

var digits = {
	0 : 'zero',
    1 : 'one',
    2 : 'two',
    3 : 'three',
    4 : 'four',
    5 : 'five',
    6 : 'six',
    7 : 'seven',
    8 : 'eight',
    9 : 'nine'
};

var teens = {
    10 : 'ten',
    11 : 'eleven',
    12 : 'twelve',
    13 : 'thirteen',
    14 : 'fourteen',
    15 : 'fifteen',
    16 : 'sixteen',
    17 : 'seventeen',
    18 : 'eighteen',
    19 : 'nineteen'
};

var tens = {
    20 : 'twenty',
    30 : 'thirty',
    40 : 'fourty',
    50 : 'fifty',
    60 : 'sixty',
    70 : 'seventy',
    80 : 'eighty',
    90 : 'ninety'
};

function wordify(number) {
    var outputStr = '';
    var hundredsDigit = Math.floor(number / 100) % 10;
    var tensDigit = Math.floor(number / 10) % 10;
    var onesDigit = number % 10;

    if (!hundredsDigit && !tensDigit && !onesDigit){
        return 'Zero';
    }

    if (hundredsDigit){
        outputStr += digits[hundredsDigit] + ' hundred';
    }

    if (tensDigit || onesDigit) {
        if (outputStr.length) {
            outputStr += ' and ';
        }

        if (tensDigit) {
            if (tensDigit === 1){
                res = outputStr + teens[tensDigit * 10 + onesDigit];
                return res[0].toUpperCase() + res.slice(1);
            }

            outputStr += tens[tensDigit * 10];
        }

        if (onesDigit) {
            if (tensDigit) {
                outputStr += ' ';
            }

            outputStr += digits[onesDigit].toLowerCase();
        }
    }
    
    return outputStr[0].toUpperCase() + outputStr.slice(1);
}

console.log(wordify(0));
console.log(wordify(9));
console.log(wordify(10));
console.log(wordify(12));
console.log(wordify(19));
console.log(wordify(25));
console.log(wordify(98));
console.log(wordify(273));
console.log(wordify(400));
console.log(wordify(501));
console.log(wordify(617));
console.log(wordify(711));
console.log(wordify(999));