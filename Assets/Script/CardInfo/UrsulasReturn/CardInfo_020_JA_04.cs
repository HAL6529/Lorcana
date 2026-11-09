using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_020_JA_04 : CardInfo
{
    public CardInfo_020_JA_04()
    {
        this.cardNo = "020_JA_04";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ÉvÉãÅ[Ég";
        this.cardName2 = "ã~èïå¢";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KennethAnderson;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
