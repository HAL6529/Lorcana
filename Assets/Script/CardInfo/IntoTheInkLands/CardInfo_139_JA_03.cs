using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_139_JA_03 : CardInfo
{
    public CardInfo_139_JA_03()
    {
        this.cardNo = "139_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "デューイ";
        this.cardName2 = "出たがり甥っ子";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FedericoMCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
