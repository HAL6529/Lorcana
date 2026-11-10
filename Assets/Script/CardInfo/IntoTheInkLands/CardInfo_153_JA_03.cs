using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_153_JA_03 : CardInfo
{
    public CardInfo_153_JA_03()
    {
        this.cardNo = "153_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ルーファス";
        this.cardName2 = "”子供の家”のネコ";
        this.power = 4;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HadjieJoos;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheRescuers;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
