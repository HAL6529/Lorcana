using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_056_JA_04 : CardInfo
{
    public CardInfo_056_JA_04()
    {
        this.cardNo = "056_JA_04";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "チクタクワニ";
        this.cardName2 = "フック船長の追っかけ";
        this.power = 4;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KennethAnderson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
