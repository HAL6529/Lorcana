using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_076_JA_13 : CardInfo
{
    public CardInfo_076_JA_13()
    {
        this.cardNo = "076_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "バズ・ライトイヤー";
        this.cardName2 = "不時着・レンジャー";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OmarLozano;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Toy, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
