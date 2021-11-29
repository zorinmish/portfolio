//
//  ViewController.swift
//  MVVM+C
//
//  Created by Mykhailo Zorin on 20.09.2021.
//

import UIKit

class ViewController: UIViewController, Storyboarded {
    weak var coordinator: MainCoordinator?
    
    override func viewDidLoad() {
        super.viewDidLoad()
    }

    @IBAction func helloTapped(_ sender: Any) {
        coordinator?.timeSubscription()
    }
    
}

