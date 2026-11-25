using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_090_JA_13 : CardInfo
{
    public CardInfo_090_JA_13()
    {
        this.cardNo = "090_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "コッパー";
        this.cardName2 = "クリエイティブな語り手";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.BrianWeisz;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Puppy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheFoxAndTheHound;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
