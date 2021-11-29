import UIKit

var greeting = "Hello, playground"

// 1 remove control flag

var foundPerson = false

let people = ["Mike", "Tom", "Fred", "Paul"]

for person in people {
    if person == "Tom" {
        print("Find \(person)")
        break
    }
    if person == "Fred" {
        print("Find \(person)")
        break
    }
}

var balance = 100
var value = 1001

//func withdraw(amount: Int) -> Int{
//  if (amount > balance) {
//    return -1;
//  }
//  else {
//    balance -= amount;
//    return 0;
//  }
//}
//
//withdraw(amount: value) == -1 ? print("Too expencive") : print("Ok")

enum WithdrawError : Error {
    case lackOfMoney
    case fortyThree
}

func withdraw(amount: Int) throws {
    if (amount > balance) {
        throw WithdrawError.lackOfMoney
      }
      else {
        balance -= amount;
      }
}

do {
    try withdraw(amount: value)
    print("Ok")
} catch WithdrawError.lackOfMoney {
    print("Too expencive")
}

class Arr {
    var nums : [Int] = []
    func pushBack(element: Int){
        nums.append(element)
    }
}

class Stack {
    private var elements: Arr = Arr()
    func push(element: Int) {
        elements.nums.insert(element, at: 0)
    }
}


