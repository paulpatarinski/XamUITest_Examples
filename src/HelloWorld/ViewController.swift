//
//  ViewController.swift
//  HelloWorld
//
//  Created by Paul Patarinski on 11/3/15.
//  Copyright (c) 2015 Paul Patarinski. All rights reserved.
//

import UIKit

class ViewController: UIViewController {

    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view, typically from a nib.
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }

    @IBAction func helloWorldBtnClicked()
    {
        let alertContoller = UIAlertController(title: "Welcome to my first app", message: "Hello World", preferredStyle: UIAlertControllerStyle.Alert)
        alertContoller.addAction(UIAlertAction(title: "OK", style: UIAlertActionStyle.Default, handler: nil))
        self.presentViewController(alertContoller, animated: true, completion: nil)
    }

}

