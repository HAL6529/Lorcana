using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_002_JA_08 : CardInfo
{
    public CardInfo_002_JA_08()
    {
        this.cardNo = "002_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "デューイ";
        this.cardName2 = "愛せる見栄っ張り";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
