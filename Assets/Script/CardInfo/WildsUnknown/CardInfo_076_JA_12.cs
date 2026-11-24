using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_076_JA_12 : CardInfo
{
    public CardInfo_076_JA_12()
    {
        this.cardNo = "076_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "バズ・ライトイヤー";
        this.cardName2 = "スペース・レンジャー";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JuanDiegoLeon;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Toy, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
