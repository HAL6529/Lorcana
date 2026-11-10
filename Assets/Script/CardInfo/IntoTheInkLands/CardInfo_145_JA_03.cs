using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_145_JA_03 : CardInfo
{
    public CardInfo_145_JA_03()
    {
        this.cardNo = "145_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉqÉÖÅ[ÉC";
        this.cardName2 = "ÇµÇ¡Ç©ÇËâôÇ¡éq";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FedericoMCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
