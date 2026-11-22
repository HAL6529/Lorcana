using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_007_JA_10 : CardInfo
{
    public CardInfo_007_JA_10()
    {
        this.cardNo = "007_JA_10";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "エロウィー";
        this.cardName2 = "リールの姫君";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.PixSmith;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheBlackCauldron;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
