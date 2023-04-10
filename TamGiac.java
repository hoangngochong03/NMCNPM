
package com.mycompany.btth02;
import java.util.*;
import java.math.*;

public class TamGiac extends DaGiac {
    private ToaDo arrayPoints[];
    
    public void nhapDaGiac(){
        Scanner scanner = new Scanner(System.in);
            int a=0;
            int b=0;
        for(int i=0;i<=2;i++){
            System.out.println("Nhap vao toa do thu" +(i+1));
            a = scanner.nextInt();
            b = scanner.nextInt();
            arrayPoints[i].setToaDo(a, b);
        }
    }
    
    public void xuatDaGiac(){
        for(int i=0;i<=2;i++){
            System.out.println("Toa do thu nhat : " + arrayPoints[i].getX());
            System.out.println("Toa do thu hai : " + arrayPoints[i].getY());
        }
    }
    
    public double dienTichDaGiac(){
        double a = arrayPoints[0].KhoangCach(arrayPoints[1].getX(), arrayPoints[1].getY());
        double b = arrayPoints[1].KhoangCach(arrayPoints[2].getX(), arrayPoints[2].getY());
        double c = arrayPoints[2].KhoangCach(arrayPoints[0].getX(), arrayPoints[0].getY());
        double q = (a+b+c) / 2;
        double dienTich = Math.sqrt(q*(q-a)*(q-b)*(q-c));
        return dienTich;
    }
    
    public double chuViDaGiac(){
        double a = arrayPoints[0].KhoangCach(arrayPoints[1].getX(), arrayPoints[1].getY());
        double b = arrayPoints[1].KhoangCach(arrayPoints[2].getX(), arrayPoints[2].getY());
        double c = arrayPoints[2].KhoangCach(arrayPoints[0].getX(), arrayPoints[0].getY());
        return a+b+c;
    }
    
    public TamGiac tinhTienDaGiac(){
        Scanner scanner = new Scanner(System.in);
        TamGiac tmp = new TamGiac();
        System.out.println("Hay nhap vector tinh tien: ");
        int a = scanner.nextInt();
        int b = scanner.nextInt();
        for(int i=0;i<2;i++){
            arrayPoints[i].setToaDo(this.arrayPoints[i].getX() + a, this.arrayPoints[i].getY() + b);
        }
        return tmp;
    }
    
}
    
