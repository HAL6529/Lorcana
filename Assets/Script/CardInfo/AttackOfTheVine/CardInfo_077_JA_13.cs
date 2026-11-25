using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_077_JA_13 : CardInfo
{
    public CardInfo_077_JA_13()
    {
        this.cardNo = "077_JA_13";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "バズ・ライトイヤー";
        this.cardName2 = "私が援護する！";
        this.power = 4;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MarcelBerg;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Toy, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
