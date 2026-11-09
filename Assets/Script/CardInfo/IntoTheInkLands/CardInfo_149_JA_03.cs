using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_149_JA_03 : CardInfo
{
    public CardInfo_149_JA_03()
    {
        this.cardNo = "149_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ÉãÅ[ÉC";
        this.cardName2 = "ÇøÇ·Ç¡Ç©ÇËâôÇ¡éq";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FedericoMCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
