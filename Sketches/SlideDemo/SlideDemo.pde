float x1, x2, x3; 
float v2;

void setup(){
  size(500,500);
}
void draw(){
  background (128);
  
  // simple, linear slide 
  
  if(x1 < mouseX) x1 += 5;
  else if(x1 > mouseX) x1 -= 5; // else causes a "ping pong" effect because it keeps going past and below the value
  
  // euler physics slide 
  
  if(x2< mouseX) v2 ++;
  if(x2 > mouseX) v2 --;
  
  x2 += v2;
  
  // damping: the exponential slide: asymtotic easing (asymtote - when a line approaches a horizontal or vertical, but never quite gets there ) 
  
 // x3 += (mouseX - x3) * .05;
  
  x3 = lerp(x3, mouseX, .05);
  
  ellipse(x1, 100, 30, 30);
  ellipse(x2, 200, 30, 30);
  ellipse(x3, 300, 30, 30);
  
}
