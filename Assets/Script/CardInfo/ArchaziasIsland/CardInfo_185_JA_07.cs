using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_185_JA_07 : CardInfo
{
    public CardInfo_185_JA_07()
    {
        this.cardNo = "185_JA_07";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ヘイヘイ";
        this.cardName2 = "さんぽのニワトリ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlanBatson;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
