using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_112_JA_13 : CardInfo
{
    public CardInfo_112_JA_13()
    {
        this.cardNo = "112_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "クマ";
        this.cardName2 = "なわばりを持つ動物";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlexandriaNeonakis;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheFoxAndTheHound;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
