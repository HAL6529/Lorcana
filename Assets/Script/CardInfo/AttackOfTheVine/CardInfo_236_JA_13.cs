using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_236_JA_13 : CardInfo
{
    public CardInfo_236_JA_13()
    {
        this.cardNo = "236_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "トッド＆コッパー";
        this.cardName2 = "君は最高だ";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RobDiSalvo;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Team, EnumController.Class.Hero, EnumController.Class.Puppy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift2, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheFoxAndTheHound;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
