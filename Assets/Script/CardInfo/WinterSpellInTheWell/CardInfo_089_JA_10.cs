using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_089_JA_10 : CardInfo
{
    public CardInfo_089_JA_10()
    {
        this.cardNo = "089_JA_10";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "スクルージ・マクダック";
        this.cardName2 = "S.H.U.S.H.エージェント";
        this.power = 0;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
