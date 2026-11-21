using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_219_JA_09 : CardInfo
{
    public CardInfo_219_JA_09()
    {
        this.cardNo = "219_JA_09";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "女王";
        this.cardName2 = "鏡の追求者";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JenniferGheduzziAndLivioCacciatore;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
