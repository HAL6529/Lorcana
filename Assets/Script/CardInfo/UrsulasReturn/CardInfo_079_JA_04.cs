using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_079_JA_04 : CardInfo
{
    public CardInfo_079_JA_04()
    {
        this.cardNo = "079_JA_04";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ÉÅÉO";
        this.cardName2 = "ñ£òfÇÃîÁì˜âÆ";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.YuNguyen;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
