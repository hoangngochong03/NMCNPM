
package com.mycompany.btth02;

import java.util.Scanner;

public class HinhChuNhat {
    
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
        double a = Points[0].KhoangCach(Points[1].getX(), Points[1].getY());
        double b = Points[1].KhoangCach(Points[2].getX(), Points[2].getY());
        return a*b;
    }
    
    public double chiViDaGiac(){
        double a = Points[0].KhoangCach(Points[1].getX(), Points[1].getY());
        return 4*a;
    }
    
    public HinhChuNhat tinhTienDaGiac(){
        Scanner scanner = new Scanner(System.in);
        HinhChuNhat tmp = new HinhChuNhat();
        System.out.println("Hay nhap vector tinh tien: ");
        int a = scanner.nextInt();
        int b = scanner.nextInt();
        for(int i=0;i<=3;i++){
            Points[i].setToaDo(this.Points[i].getX() + a, this.Points[i].getY() + b);
        }
        return tmp;
    }
}
