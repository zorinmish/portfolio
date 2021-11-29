//
//  Coordinator.swift
//  MVVM+C
//
//  Created by Mykhailo Zorin on 20.09.2021.
//

import Foundation
import UIKit

protocol Coordinator  {
    var childCoordinators: [Coordinator] {get set}
    var navigationController: UINavigationController {get set}
    
    func start()
}
