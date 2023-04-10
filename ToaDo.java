
package com.mycompany.btth02;
import java.math.*;

public class ToaDo {
        private double x;
        private double y;
        
        void setToaDo(double x,double y){
            this.x = x;
            this.y = y;
        }
        double getX(){
            return this.x;
        };
        double getY(){
            return this.y;
        }
        double KhoangCach(double x,double y){
            return Math.sqrt((this.x - x) * (this.x - x) + (this.y - y) * (this.y - y));
        }
}
