using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_196_JA_08 : CardInfo
{
    public CardInfo_196_JA_08()
    {
        this.cardNo = "196_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ナサニエル・フリント";
        this.cardName2 = "悪名高き海賊";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EduFrancisco;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Alien, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TreasurePlanet;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
