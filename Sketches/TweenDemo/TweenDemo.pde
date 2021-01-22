
float valStart = 0;
float valEnd = 500;

float animLength = 5;
float animPlayheadTime = 0; // these are in seconds 
boolean isTweenPlaying = false;

float prevTimestamp = 0;

void setup(){
  size(500, 500);
}
void draw(){
  background(128); // fill screen with 50% grey
  
  float currTimestamp = millis()/1000.0;
  float dt = currTimestamp - prevTimestamp;
  prevTimestamp = currTimestamp;
  
  // move playhead forward in time:
  if(isTweenPlaying){
    animPlayheadTime += dt;
    // stop playing at the end of tween:
    if(animPlayheadTime > animLength) {
    isTweenPlaying = false;
    animPlayheadTime = animLength;
}
  }
  //println(animPlayheadTime);
  
  // percent:
 float p = animPlayheadTime / animLength;
 
 // manipulate 'p'
 //p = p *p; // "bends" the curve down - ease in
 //p = 1 - (1-p) *(1-p); //bends the curve up - ease out
  p = p * p * (3-2*p);
 float x =  lerp(valStart, valEnd, p);

 ellipse(x, height/2.0, 20, 20);
  
  
}
void mousePressed(){
  animPlayheadTime = 0; // restarts animation
  isTweenPlaying = true;
  
}
