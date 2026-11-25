using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_010_JA_13 : CardInfo
{
    public CardInfo_010_JA_13()
    {
        this.cardNo = "010_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "リロ";
        this.cardName2 = "根気強いかご編み娘";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.PatriBalanovsky;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
