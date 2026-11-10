using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_013_JA_03 : CardInfo
{
    public CardInfo_013_JA_03()
    {
        this.cardNo = "013_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "オービル";
        this.cardName2 = "エースパイロット";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.IsaiahMesq;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheRescuers;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
