using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_144_JA_03 : CardInfo
{
    public CardInfo_144_JA_03()
    {
        this.cardNo = "144_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ジャイロ・ギアルーズ";
        this.cardName2 = "ガジェット作りの天才";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarioOscarGabriele;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
