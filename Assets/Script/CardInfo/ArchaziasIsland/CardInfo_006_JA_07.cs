using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_006_JA_07 : CardInfo
{
    public CardInfo_006_JA_07()
    {
        this.cardNo = "006_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "トラスティ";
        this.cardName2 = "義理堅いブラッドハウンド";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.YuNguyen;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.LadyAndTheTramp;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
