using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_156_JA_03 : CardInfo
{
    public CardInfo_156_JA_03()
    {
        this.cardNo = "156_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "èóâ§";
        this.cardName2 = "ãæÇÃí«ãÅé“";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JenniferGheduzziAndLivioCacciatore;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
