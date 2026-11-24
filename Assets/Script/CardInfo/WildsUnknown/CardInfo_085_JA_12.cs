using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_085_JA_12 : CardInfo
{
    public CardInfo_085_JA_12()
    {
        this.cardNo = "085_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "バズ・ライトイヤー";
        this.cardName2 = "さあ！来い！";
        this.power = 4;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MaxGrecke;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Toy, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
