using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_204_JA_01 : CardInfo
{
    public CardInfo_204_JA_01()
    {
        this.cardNo = "204_JA_01";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "プラズマブラスター";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = "Oleg Yurkov";
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}
