using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_055_JA_04 : CardInfo
{
    public CardInfo_055_JA_04()
    {
        this.cardNo = "055_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ピコ";
        this.cardName2 = "お助けオオハシ";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HadjieJoos;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
