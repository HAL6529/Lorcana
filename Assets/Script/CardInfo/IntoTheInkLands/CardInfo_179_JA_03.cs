using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_179_JA_03 : CardInfo
{
    public CardInfo_179_JA_03()
    {
        this.cardNo = "179_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "リトル・ジョン";
        this.cardName2 = "ロビンの相棒";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JacobMcAlister;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
