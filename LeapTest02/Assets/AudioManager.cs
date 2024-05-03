using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;

    public AudioClip backgroundEx1;
    public AudioClip backgroundEx2;
    public AudioClip backgroundEx3;
    AudioClip bgInstruction;


    private void Start()
    {
        // Return the current Active Scene in order to get the current Scene name.
        Scene scene = SceneManager.GetActiveScene();
        
        switch (scene.name)
        {
            case "Ex1-AbreFecha-Scene":
                bgInstruction = backgroundEx1;
                break;
            case "Ex2-CimaBaixo-Scene":
                bgInstruction = backgroundEx2;
                break;
            case "Ex3-PinchStrength-Scene":
                bgInstruction = backgroundEx3;
                break;
        }
        if (bgInstruction != null)
        {
            musicSource.clip = bgInstruction;
            musicSource.Play();
        }
        
    }
}
