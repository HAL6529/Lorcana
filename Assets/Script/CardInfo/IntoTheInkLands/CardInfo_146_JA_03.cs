using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_146_JA_03 : CardInfo
{
    public CardInfo_146_JA_03()
    {
        this.cardNo = "146_JA_03";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "キング・ルーイ";
        this.cardName2 = "バンドリーダー";
        this.power = 7;
        this.toughness = 7;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.KennethAnderson;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
