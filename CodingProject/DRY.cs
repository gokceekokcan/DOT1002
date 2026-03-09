public class ResourceManager 
{
        public void UpdateResource(string name, int amount) 
    {
        Console.WriteLine($"{name} Amount: {amount}");
    }
    
}

private AudioSource _audioSource;

{
  _audioSource = GetComponent<AudioSource>();
}

void PlaySound(AudioClip clip, float pitchMin = 0.95f, float pitchMax = 1.05f)
{
    if (clip == null) return;
    
    _audioSource.pitch = Random.Range(pitchMin, pitchMax); 
    _audioSource.PlayOneShot(clip); 
}

void Jump() {
    PlaySound(jumpSound);
    rb.velocity = Vector2.up * jumpForce;
}

void Shoot() {
    PlaySound(shootSound);
    Instantiate(bullet, transform.position, Quaternion.identity);
}