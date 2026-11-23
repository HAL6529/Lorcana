using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_124_JA_11 : CardInfo
{
    public CardInfo_124_JA_11()
    {
        this.cardNo = "124_JA_11";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "スクルージ・マクダック";
        this.cardName2 = "エブニーザー・スクルージ";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HedvigH_S;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
