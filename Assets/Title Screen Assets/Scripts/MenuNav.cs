using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuNav : MonoBehaviour
{
    
    public Image pokemonDisplay;
    public Image backgroundImage;
    public TextMeshProUGUI pokemonNameText;
    public TextMeshProUGUI pokemonDescriptionText;
    public Button chooseButton;

    public Sprite charizardSprite;
    public Sprite blastoiseSprite;
    public Sprite venusaurSprite;

    public Sprite charizardBackground;
    public Sprite blastoiseBackground;
    public Sprite venusaurBackground;

    private string[] pokemonNames = { "Charizard", "Blastoise", "Venusaur" };
    private string[] pokemonDescriptions = {
        "A fierce Fire-type Pokémon with powerful flames.",
        "A Water-type Pokémon with a strong shell.",
        "A Grass-type Pokémon with a giant flower on its back."
    };
    private int currentIndex = 0;

    void Start()
    {
        UpdatePokemonDisplay();
    }

    void UpdatePokemonDisplay()
    {
        switch (currentIndex)
        {
            case 0:  // Charizard
                pokemonDisplay.sprite = charizardSprite;
                backgroundImage.sprite = charizardBackground;
                break;
            case 1:  // Blastoise
                pokemonDisplay.sprite = blastoiseSprite;
                backgroundImage.sprite = blastoiseBackground;
                break;
            case 2:  // Venusaur
                pokemonDisplay.sprite = venusaurSprite;
                backgroundImage.sprite = venusaurBackground;
                break;
        }

        pokemonNameText.text = pokemonNames[currentIndex];
        pokemonDescriptionText.text = pokemonDescriptions[currentIndex];
    }

    public void OnLeftArrowClicked()
    {
        currentIndex = (currentIndex - 1 + pokemonNames.Length) % pokemonNames.Length;
        UpdatePokemonDisplay();
    }
    public void OnRightArrowClicked()
    {
        currentIndex = (currentIndex + 1) % pokemonNames.Length;
        UpdatePokemonDisplay();
    }

    public void OnChooseButtonClicked()
    {
        // Save the selected Pokémon and load the battle scene
        //PokemonSelectionManager.selectedPokemon = pokemonNames[currentIndex];
        //SceneManager.LoadScene("BattleScene");
    }
}
