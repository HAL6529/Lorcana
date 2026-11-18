using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_058_JA_08 : CardInfo
{
    public CardInfo_058_JA_08()
    {
        this.cardNo = "058_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ポー・デ・スペル";
        this.cardName2 = "マジカの弟";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KamilMurzyn;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
