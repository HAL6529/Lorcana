using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_142_JA_11 : CardInfo
{
    public CardInfo_142_JA_11()
    {
        this.cardNo = "142_JA_11";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "シーナ";
        this.cardName2 = "見守る母";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.YuNguyenAndMarianaMoreno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Alert };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
