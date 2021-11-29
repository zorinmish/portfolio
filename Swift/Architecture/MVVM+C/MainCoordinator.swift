//
//  MainCoordinator.swift
//  MVVM+C
//
//  Created by Mykhailo Zorin on 20.09.2021.
//

import Foundation
import UIKit

class MainCoordinator: Coordinator {
    var childCoordinators = [Coordinator]()
    var navigationController: UINavigationController
    
    init(navController: UINavigationController){
        self.navigationController = navController
    }
    
    func start() {
        let vc = ViewController.instantiate()
        vc.coordinator = self
        navigationController.pushViewController(vc, animated: false)
    }
    
    func timeSubscription() {
        let vc = TimeViewController.instantiate()
        vc.coordinator = self
        navigationController.pushViewController(vc, animated: true)
    }
}
