#pragma strict

var movie_stills : Texture[] = new Texture[1];
var number_of_stills = 1;
var Loop = false;
var fps = 30;
var Sound : AudioClip;
 
private var stills = 0;
private var play = true;
 
function Update () {
    if(fps > 0){
        if(play == true){
            Player();
        }
    } else {
        Debug.LogError("'fps' must be set to a value greater than 0.");
    }
}
 
function Player(){
    play = false;
    if(Loop){
        if(stills > number_of_stills) {
            audio.Stop();
            audio.clip = Sound;
            audio.Play();
            stills = 0;
        }
    } else {
        if(stills > number_of_stills) {
            audio.Stop();
            stills -= 1;
        }
    }
    var MainTex = movie_stills[stills];
    renderer.material.SetTexture("_MainTex", MainTex);
    stills += 1;
    var fps_fixer = fps*3;
    var wait_time = 1.0/fps_fixer;
    yield WaitForSeconds(wait_time);
    if(!audio.clip){
        if(Sound){
            audio.clip = Sound;
            audio.Play();
        }
    }
    play = true;
}
 
function Start ()
{
    audio.loop = false;
    number_of_stills -= 1;
}