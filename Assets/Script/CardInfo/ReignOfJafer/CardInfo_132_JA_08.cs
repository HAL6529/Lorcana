using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_132_JA_08 : CardInfo
{
    public CardInfo_132_JA_08()
    {
        this.cardNo = "132_JA_08";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ラフィエット";
        this.cardName2 = "ねむたげバセットハウンド";
        this.power = 7;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SaraLeal_Loyal;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheAristocats;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
