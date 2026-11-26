using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_039_JA_14 : CardInfo
{
    public CardInfo_039_JA_14()
    {
        this.cardNo = "039_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "マーリン";
        this.cardName2 = "光り物の専門家";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LauraDePascale;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
