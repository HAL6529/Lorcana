using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_152_JA_03 : CardInfo
{
    public CardInfo_152_JA_03()
    {
        this.cardNo = "152_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "プルート";
        this.cardName2 = "ミッキーのかしこい友だち";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RiantiHidayatAndAlicePisoni;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
