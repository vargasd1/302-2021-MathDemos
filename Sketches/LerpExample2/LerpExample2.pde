
void setup(){
  size(500,500);
}

void draw(){
  background(128);
  
  float p = millis() / 2000.0;
  float size = lerp(50, 300, p);
  
  fill(p * 255);
  
  ellipse(width/2, height/2, size, size);
  
}

// lerp functions ( with overloading)

float lerpy(float min, float max, float p){

    return lerpy(min, max, p, true);
}

float lerpy(float min, float max, float p, boolean allowExtrapolation ) {
  
  if(allowExtrapolation == false) {
  if(p < 0) p = 0;
  if(p > 1) p = 1;
  }  
  
  return min + (max - min) * p;
}
