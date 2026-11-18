using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_107_JA_08 : CardInfo
{
    public CardInfo_107_JA_08()
    {
        this.cardNo = "107_JA_08";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ゴー・ゴー・トマゴ";
        this.cardName2 = "最先端";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.BenoMeli;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
