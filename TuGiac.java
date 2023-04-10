
package com.mycompany.btth02;

import java.util.Scanner;
import java.math.*;

public class TuGiac {
    
    private ToaDo Points[];
    
    public void nhapDaGiac(){
         Scanner scanner = new Scanner(System.in);
            int a=0;
            int b=0;
        for(int i=0;i<=3;i++){
            System.out.println("Nhap vao toa do thu" +(i+1));
            a = scanner.nextInt();
            b = scanner.nextInt();
            Points[i].setToaDo(a, b);
        }
    }
    
    
    public void xuatDaGiac(){
        for(int i=0;i<=3;i++){
            System.out.println("Toa do thu nhat : " + Points[i].getX());
            System.out.println("Toa do thu hai : " + Points[i].getY());
        }
    }
    
    public double dienTichDaGiac(){
        double dienTich;
        //canh tu giac
         double a = Points[0].KhoangCach(Points[1].getX(), Points[1].getY());
         double b = Points[1].KhoangCach(Points[2].getX(), Points[2].getY());
         double c = Points[2].KhoangCach(Points[3].getX(), Points[3].getY());
         double d = Points[3].KhoangCach(Points[0].getX(), Points[0].getY());
        ///Duong cheo
        double e = Points[0].KhoangCach(Points[2].getX(), Points[2].getY());
        double f = Points[1].KhoangCach(Points[3].getX(), Points[3].getY());
        
        /// e^2 = a^2 + b^2 - 2|a|*|b|*cos(alpha)
        /// cos(alpha) = (e^2 - a^2 -b^2)/2|a||b|
        double sinAlpha = Math.sqrt(1-Math.pow(((e*e - a*a - b*b)/(2*Math.abs(a)+Math.abs(b))), 2));
        double sinBeta = Math.sqrt(1-Math.pow(((f*f - c*c - d*d)/(2*Math.abs(c)*Math.abs(d))), 2));
        return (a*b*sinAlpha)/2 + (c*d*sinBeta);
    }
    
    public double chiViDaGiac(){
        double a = Points[0].KhoangCach(Points[1].getX(), Points[1].getY());
         double b = Points[1].KhoangCach(Points[2].getX(), Points[2].getY());
         double c = Points[2].KhoangCach(Points[3].getX(), Points[3].getY());
         double d = Points[3].KhoangCach(Points[0].getX(), Points[0].getY());
         return a+b+c+d;
    }
    
    public TuGiac tinhTienDaGiac(){
        Scanner scanner = new Scanner(System.in);
        TuGiac tmp = new TuGiac();
        System.out.println("Hay nhap vector tinh tien: ");
        int a = scanner.nextInt();
        int b = scanner.nextInt();
        for(int i=0;i<=3;i++){
            Points[i].setToaDo(this.Points[i].getX() + a, this.Points[i].getY() + b);
        }
        return tmp;
    }
}
